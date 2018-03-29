## <span>What's new in C#</span>
<img src="assets/me.jpg" height="375" />
<br />
[@davidpine7](https://twitter.com/davidpine7) | [davidpine.net](http://davidpine.net/)

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
- <i class="fa fa-hand-paper-o waving"></i> Goodbye `.Item1`, `.Item2`, ...
- Value-Type
- Literals / Deconstruct Anything

+++?code=src/Tuples.cs&lang=csharp
@[1-8](Legacy Tuples, @fa[trademark] "Allocatey" @fa[frown-o])
@[10-16](New Tuple, Literal Expression, Mutable @fa[meh-o])
@[18-21](Extension Method @fa[meh-o])
@[23-25](Generic, Any Type @fa[meh-o])
@[27-32](Explicitly Named Members, Hidden API @fa[meh-o])
@[34-40](Deconstruction, Various Approaches @fa[meh-o])
@[35-47](Works As Expected @fa[smile-o])
@[49-51](Literal Immediate Deconstruct @fa[thumbs-o-up])
@[69-77](Any Class @fa[question-circle])
@[79-84](Deconstruct @fa[exclamation-circle])
@[54-67](It Just Works @fa[exclamation])

+++

# C# 7
## Pattern Matching

- Constant & Type Patterns
- `is` Expressions
- Smarter `switch` Statements 

+++?code=src/PatternMatching.cs&lang=csharp
@[1-7](Constant Pattern @fa[smile-o])
@[9-17](Type Pattern @fa[smile-o])
@[14-20](Same Scoping @fa[smile-o])
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
- Numeric Literal Syntax Improvements
- `ref` Locals and Returns

+++

# C# 7
## Additional Features

### [bit.ly/csharp-seven-features](http://bit.ly/csharp-seven-features)

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

+++

# C# 8
## Nullable<br/>Reference Types

- Billion @fa[usd] Mistake
- Express Intent
- Flow Analysis
- Type Inference

+++

... code examples

+++
# Thank you
<br/>
### Slides: [bit.ly/newcsharp](http://bit.ly/newcsharp)
### Source: [bit.ly/csharp-src](http://bit.ly/csharp-src)
<br/>
[@davidpine7](https://twitter.com/davidpine7) | [davidpine.net](http://davidpine.net/)
