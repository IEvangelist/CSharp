## <span>What's new in C#</span>
<img src="assets/me.jpg" height="375" />
<br />
[@davidpine7](https://twitter.com/davidpine7) | [davidpine.net](http://davidpine.net/)

+++

# C# 7
## Local Functions

- Recursive
- `async` and `await`
- Iterators
- Generics

+++?code=src/LocalFunctions.cs&lang=csharp
@[1-11](Eager Validation: Early Exit, Iterator: Deferred Execution)
@[13-21](Solution: Separate Methods?)
@[23-27](Logical Cohesion @fa[meh-o fa-lg])
@[13-27](Where Else Is This Used? @fa[frown-o fa-lg])
@[29-43](Local Functions! @fa[smile-o fa-lg])
@[45-49](Not As Ugly @fa[fa-thumbs-o-up fa-lg])

+++

# C# 7
## Out Variables

- Same Scoping Rules
- Implicit Declaration
- Valid With Ternary 

+++?code=src/OutVariables.cs&lang=csharp
@[1-11](TryParse: Legacy Pattern @fa[frown-o fa-lg])
@[13-22](New Pattern @fa[meh-o fa-lg])
@[24-32](Same Scoping Rules @fa[smile-o fa-lg])
@[34-35](Valid With Ternary @fa[fa-thumbs-o-up fa-lg])

+++

# C# 7
## Tuples

- Hashing / Dictionary Key
- API Better, `.Item1`, `.Item2`, ...
- Value-Type
- Literals / Deconstruction

+++?code=src/Tuples.cs&lang=csharp
@[1-8](Legacy Tuples, Class @fa[frown-o fa-lg])
@[10-16](... @fa[meh-o fa-lg])
@[18-21](... @fa[meh-o fa-lg])
@[23-25](... @fa[meh-o fa-lg])
@[27-32](... @fa[meh-o fa-lg])
@[34-40](... @fa[meh-o fa-lg])
@[38-47](... @fa[smile-o fa-lg])
@[49-51](Same Scoping Rules @fa[fa-thumbs-o-up fa-lg])

+++




// Prior to C# 7, Tuples existed as an API - but had many limitations.
// You are probably familiar with the .Item1, .Item2, .Item3, etc...

// Benefits:
//    Readability and "Immutable", relies on System.ValueTuple.dll

