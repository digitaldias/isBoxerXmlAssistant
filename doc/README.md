# xmlAssistant
xmlAssistant is a very simple console application that 
helps you author mapped keys in sequence for the multi-boxing application [IsBoxer](https://isboxer.com/). 

>**WARNING**<br />
> This tool assumes that you are familiar with editing XML files and that you can find your way around the configuration file that you have created with [IsBoxer](https://isboxer.com/).
> If you are uneasy editing XML files, then **do not use this tool!**


## Usage
**xmlAssistant** &lt;operation&gt; [parameters]

*Simply typing **xmlAssistant** on its own reveales the syntax.*

---

## Supported Operations

### Help
Simply type **xmlAssistant** or use the parameter -h or --help to display help. 

---

### keyStrokes
Creates a sequence of MappedKeyActions of type 'KeyStroke' where each character in the input string are a single keystroke Input string is a required argument to keyStrokes, use double quotes.

Parameters: &lt;input string&gt;
Example:
```csharp
C:\> xmlAssistant keystrokes "/loc"
```
Produces the following output: 
```xml
<Actions>
    <MappedKeyAction xsi:type="Keystroke">
        <Combo>
            <Combo>
                /
            </Combo>
            <Key>
                <Key>
                    /
                </Key>
            </Key>
        </Combo>
    </MappedKeyAction>
    <MappedKeyAction xsi:type="Keystroke">
        <Combo>
            <Combo>
                L
            </Combo>
            <Key>
                <Key>
                    L
                </Key>
            </Key>
        </Combo>
    </MappedKeyAction>
    <MappedKeyAction xsi:type="Keystroke">
        <Combo>
            <Combo>
                O
            </Combo>
            <Key>
                <Key>
                    O
                </Key>
            </Key>
        </Combo>
    </MappedKeyAction>
    <MappedKeyAction xsi:type="Keystroke">
        <Combo>
            <Combo>
                C
            </Combo>
            <Key>
                <Key>
                    C
                </Key>
            </Key>
        </Combo>
    </MappedKeyAction>
</Actions>

```
Results are written to standard output, so if you choose, you can redirect the output to, for example, a file: 

```csharp
C:\> xmlAssistant keystrokes "/alt act 10429" > disc10429.xml
```

Enjoy. 
If you found this tool helpful, I'd [apprecitate a cup of coffee](https://ko-fi.com/digitaldias), but that is entirely up to you. 

Enjoy

