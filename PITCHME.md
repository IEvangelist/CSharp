## <span>What's new in C#</span>
<img src="assets/me.jpg" height="375" />
<br />
[@davidpine7](https://twitter.com/davidpine7) | [davidpine.net](http://davidpine.net/)

+++?image=assets/imposter.png&size=contain
<h2 id='iHeart'>I @fa[heart] .NET</h2>

+++

# Agenda
<br/>
### Major Features of C# 7
### & Look Ahead at C# 8

+++

# C# 7
## Local Functions

- Supports Recursion
- `async` and `await` Methods
- Iterators
- Generics

+++?code=src/LocalFunctions.cs&lang=csharp
@[1-11](Early Exit, Iterator: Deferred Execution)
@[13-21](Solution: Separate Methods? @fa[thumbs-o-down])
@[23-27](Logical Cohesion @fa[meh-o])
@[13-27](Where Else Is This Used? @fa[frown-o])
@[29-43](Local Functions! @fa[smile-o])
@[45-49](Not As Ugly @fa[thumbs-o-up])

+++

# C# 7
## Out Variables

- Same Scoping Rules
- Implicit `var` Declaration
- Valid With Ternary 

+++?code=src/OutVariables.cs&lang=csharp
@[1-11](Legacy Pattern @fa[frown-o])
@[13-22](New Pattern @fa[meh-o])
@[24-32](Same Scoping Rules @fa[smile-o])
@[34-35](Valid With Ternary @fa[thumbs-o-up])

+++

# C# 7
## Tuples

- Dictionary Key / `.GetHashCode()`
- <i class="fa fa-hand-paper-o waving"></i> Goodbye to `.Item1`, `.Item2`, ...
- Say Hello to `ValueTuple`
- Literals / Deconstruction

+++?code=src/Tuples.cs&lang=csharp
@[1-8](Legacy Tuples, @fa[trademark] "Allocatey" @fa[frown-o])
@[10-16](New Tuple, Literal Expression, Mutable @fa[meh-o])
@[18-21](Extension Method @fa[meh-o])
@[23-25](Generic, Any Type @fa[meh-o])
@[27-32](Explicitly Named Members, Hidden API @fa[smile-o])
@[34-40](Deconstruction, Various Approaches @fa[smile-o])
@[35-47](Works As Expected @fa[smile-o])
@[49-51](Literal Immediate Deconstruct @fa[thumbs-o-up])
@[69-77](A Simple Class @fa[question-circle])
@[79-84](Deconstruct Everything @fa[exclamation-circle])
@[54-67](It Just Works @fa[exclamation])
@[90-98](Deconstruct Extensions @fa[smile-o])
@[100-104](Testing With `null` @fa[thumbs-o-up])
@[107-113](Testing With Value @fa[exclamation])

+++

# C# 7
## Pattern Matching

- Constant & Type Patterns
- `is` Expressions
- Smarter `switch` Statements 

+++?code=src/PatternMatching.cs&lang=csharp
@[1-7](Constant Pattern @fa[smile-o])
@[9-17](Type Pattern @fa[smile-o])
@[14-20](Familiar Scoping @fa[smile-o])
@[23-36](Shape @fa[meh-o])
@[38-48](Circle @fa[meh-o])
@[50-56](Rectangle or Square @fa[meh-o])
@[58-59](Output Shapes @fa[smile-o])
@[60-78](Switch Statement @fa[smile-o])
@[65-67](Circle @fa[thumbs-o-up])
@[68-70](Square @fa[exclamation-circle])
@[71-73](Rectangle @fa[exclamation])

+++

# C# 7
## Additional Features

- `throw` Expressions
- Generalized `async` Returns
- `0b0001_0000` Binary Literals
- `ref` Locals and Returns

+++

# C# 7
## Additional Features

### [bit.ly/csharp-seven-features](http://bit.ly/csharp-seven-features)

+++

# C# 8
## Disclaimer

### Proposals & Prototypes
+++

# C# 8
## Default<br/>Interface Methods

- Safely Add New APIs
- Default Behavior

+++?code=src/DefaultInterfaceMethods.cs&lang=csharp

@[1-3](We Have An Interface @fa[meh-o])
@[5-12](We Want To Add An API @fa[frown-o])
@[14-24](We Add Default Impl @fa[smile-o])

+++

# C# 8
## Async Streams

- Both Iterator & `async` Method
- `IAsyncDisposable`
- `IAsyncEnumerator<T>` & `IAsyncEnumerable<T>`
- Differs From `IObserver<T>` & `IObservable<T>`

+++?code=src/AsyncStreams.cs&lang=csharp

@[1-12](New Interface, `IAsyncDisposable` @fa[smile-o])
@[14-26](Iterator's Today @fa[smile-o])
@[28-40](`async` Iterator's @fa[thumbs-o-up])
@[42-48](Consumption @fa[exclamation-circle])

+++

# C# 8
## Nullable<br/>Reference Types

- `null =>` Billion @fa[usd] Mistake
- Express Intent
- Flow Analysis

+++?code=src/NullableReferenceTypes.cs&lang=csharp

@[1-17](`Person` Object @fa[meh-o])
@[15-16](Note `.ctor` @fa[meh-o])
@[19-24](What Do We Expect? @fa[frown-o])
@[26-32](Express Intent @fa[question])
@[28](`MiddleName` can be `null` @fa[question-o])
@[34-39](IDE warns you @fa[smile-o])
@[41-48](Take Suggestions @fa[frown-o])

+++

# C# 8
## Additional Features

### [bit.ly/csharp-8-features](http://bit.ly/csharp-8-features)

+++?image=assets/cuzCSharp.png&size=contain
+++

# Thank you
<br/>
### Slides: [bit.ly/newcsharp](http://bit.ly/newcsharp)
### Source: [bit.ly/csharp-src](http://bit.ly/csharp-src)
<br/>
[@davidpine7](https://twitter.com/davidpine7) | [davidpine.net](http://davidpine.net/)
