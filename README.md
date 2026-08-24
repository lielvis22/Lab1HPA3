# Laboratorio #1 – Herramientas de la Programación Aplicada III (.Net)

**Universidad Tecnológica de Panamá**
**Facultad de Ingeniería Eléctrica – Campus Víctor Levis Sasso**
**Elaborado por:** Ing. Irina Fong
**Programado por:** Elvis Li

Repositorio con las soluciones a las 3 prácticas del Laboratorio #1: aplicaciones de **Windows Forms (.NET Framework)** en C#, cubriendo controles básicos, estructuras condicionales y validación de datos.

---

## 📁 Contenido del repositorio

| Carpeta / Proyecto | Práctica | Descripción |
|---|---|---|
| `Pract1_Controles_ProgramadoPor_ElvisLi` | Práctica #1 | Captura de fecha (día, mes, año) usando TextBox, Label y Button |
| `Pract2_Descuento_ProgramadoPor_ElvisLi` | Práctica #2 | Calculadora de descuentos por rango de venta |
| `Pract3_Estructura_ProgramadoPor_ElvisLi` | Práctica #3 | Calculadora con GroupBox y RadioButtons (Suma, Resta, Multiplicación, División) |

---

## ⚙️ Requisitos

- **Visual Studio** (2019 o superior recomendado)
- **.NET Framework 4.7.2** (o el que tengas configurado en cada proyecto)
- Sistema operativo **Windows** (Windows Forms no corre en Mac/Linux)

---

## ▶️ Cómo ejecutar cada práctica

1. Clona o descarga este repositorio.
2. Abre el archivo `.sln` de la práctica que quieras correr (por ejemplo, `Pract3_Estructura_ProgramadoPor_ElvisLi.sln`).
3. Presiona **Ctrl+Shift+B** para compilar.
4. Presiona **F5** para ejecutar.

---

## 🧩 Práctica #1 — Pract1-Controles

Formulario que captura una fecha (día, mes, año) y la muestra formateada, con validación de campos vacíos.

**Controles principales:**
| Control | Nombre |
|---|---|
| TextBox | `txtDia`, `txtMes`, `txtAnio` |
| TextBox / Label resultado | `txtResultado` / `lblResultado` |
| Button | `btnMostrar` ("Enviar"), `btnSalir` ("Salir") |

**Funcionalidad:**
- **Enviar:** valida que ningún campo esté vacío, concatena la fecha con espacios y la muestra.
- **Salir:** muestra dos mensajes ("Se cerrará la ventana" y "Cerrando") y cierra la aplicación.

---

## 🧩 Práctica #2 — Descuentos

Calculadora de descuentos según el valor de una venta:

| Rango de venta | Descuento |
|---|---|
| ≥ $500 | 30% |
| $300 – $499 | 20% |
| $100 – $299 | 10% |
| ≤ $100 | 0% |

**Controles principales:**
| Control | Nombre |
|---|---|
| TextBox | `txtValorVenta`, `txtDescuento`, `txtDescuentoPorcentaje`, `txtVentaFinal` |
| Button | `btnCalcular`, `btnLimpiar`, `btnSalir` |

**Funcionalidad:**
- **Calcular:** valida el valor ingresado (`decimal.TryParse`) y aplica el descuento correspondiente según estructura `if / else if / else`.
- **Limpiar:** vacía todos los campos.
- **Salir:** confirma con mensaje y cierra la aplicación.

---

## 🧩 Práctica #3 — Estructura If (GroupBox + RadioButtons)

Calculadora que realiza una operación matemática entre dos valores según el RadioButton seleccionado dentro de un GroupBox.

**Controles principales:**
| Control | Nombre |
|---|---|
| TextBox | `txtValor1`, `txtValor2`, `txtResultado` |
| Label | `lblSimbolo` (símbolo dinámico), `lblIgual` |
| GroupBox | `groupBox1` |
| RadioButton | `rbSuma`, `rbResta`, `rbMultiplicacion`, `rbDivision` |
| Button | `button1` ("Calcular"), `button2` ("Salir") |

**Funcionalidad:**
- **Calcular:** valida campos vacíos y valores numéricos, determina la operación según el RadioButton marcado, actualiza el símbolo (`+`, `-`, `*`, `/`) y calcula el resultado. Valida división entre cero.
- **Salir:** confirma con mensaje y cierra la aplicación.

---

## ✅ Checklist general antes de entregar

- [ ] Cada formulario muestra el título correcto en la barra de título
- [ ] Todos los TextBox usan el prefijo `txt`, Labels `lbl`, Buttons `btn`
- [ ] Se valida que los campos no estén vacíos antes de calcular
- [ ] Se valida que los valores ingresados sean numéricos (`TryParse`)
- [ ] Los botones "Salir" muestran mensaje de confirmación antes de cerrar
- [ ] El proyecto compila sin errores (`Ctrl+Shift+B`) y corre con `F5`

---

## 🛠️ Solución de problemas comunes

### ❌ `CS0246`: "The type or namespace name 'Form1' could not be found" (en `Program.cs`)
El `namespace` de `Program.cs` no coincide con el de `Form1.cs` / `Form1.Designer.cs`.
**Solución:** verifica que los 3 archivos tengan **exactamente** el mismo `namespace`.

### ❌ Un botón "no hace nada" al hacer clic
El evento `Click` no está conectado en el diseñador.
**Solución:** en `Form1.Designer.cs`, busca la sección del botón y confirma que tenga una línea como:
```csharp
this.button2.Click += new System.EventHandler(this.button2_Click);
```
Si falta, agrégala manualmente debajo de `UseVisualStyleBackColor`, o conéctala desde el panel de Propiedades (⚡ Events) en el diseñador.

### ❌ "The designer cannot process unknown name 'xxx_Click'"
Hay una línea en `Form1.Designer.cs` conectando un evento a un método que no existe en `Form1.cs` (usualmente por un doble clic accidental sobre un control).
**Solución:** agrega el método vacío correspondiente en `Form1.cs`, o borra esa línea de conexión en el `Designer.cs`.

### ❌ El diseñador visual no abre, pero el programa corre bien con F5
Es un problema de caché del diseñador, no de tu código.
**Solución:**
1. Cierra todas las pestañas y la solución completa.
2. Cierra Visual Studio.
3. Borra las carpetas `bin` y `obj` del proyecto.
4. Reabre el `.sln`, compila (`Ctrl+Shift+B`) y abre el diseñador de nuevo.

### ❌ "An Application Control policy has blocked this file" (Smart App Control)
Windows 11 bloquea el `.exe` recién compilado por no tener firma digital reconocida.
**Solución (solo en PC personal):** Configuración → Seguridad de Windows → Control de aplicaciones y del explorador → Smart App Control → Desactivar.
⚠️ Acción **irreversible sin reinstalar Windows** — no la actives en equipos de laboratorio/universidad sin autorización.

---

## 📚 Conceptos aplicados

- Estructura `if / else if / else`
- `decimal.TryParse()` para validar entradas numéricas
- `string.IsNullOrWhiteSpace()` para validar campos vacíos
- `MessageBox.Show()` para mensajes al usuario
- Concatenación de cadenas con `+` y `+=`
- `RadioButton.Checked` y `GroupBox` para selección exclusiva de opciones
- Manejo de errores comunes (división entre cero, entradas no numéricas)
- Nomenclatura de controles (`txt`, `lbl`, `btn`, `rb`)

---

## 👤 Autor

**Elvis Li**
Universidad Tecnológica de Panamá — Facultad de Ingeniería Eléctrica
