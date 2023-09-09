# General Rules
1. Developers should agree on a standard for code formatting. Goal: a developer should be able to look at a class and not be able to determine who wrote it. Makes it easier for developers to fix each other's bugs.
1. Not everything needs to be a MonoBehaviour
1. Gain control of the startup sequence of the scene. Do not blindly rely on Awake and Start.
1. If a class has a public property that needs it's reference set in the Inspector, provide valuable feedback when the property is null so that other developers, and your future you, knows how to fix the problem when you forget to set the value.
1. Think about code reuse, but don't be fanatic about it. Split your code into multiple generic classes that can be reused in other parts of the game, and possibly future games.
1. Think about performance, but don't try to fix a problem before it actually is a problem. Premature optimizations always eats up much more of your time than you think. Don't be sloppy about it. You don't want to paint yourself into a corner and have to rewrite all code when you actually need to optimize. Be a good architect and build your software in a way that you don't need to optimize, and that it makes it easier for you to change when you do need to optimize.
1. Decouple! When you need to setup a new scene to test a specific feature, you don't want to have hardcoded references to all other classes in your code. You should be able to take out only a few systems and make them run independently.
1. Always close Unity before committing code to the repo. That way Unity will have generated all meta files for newly added resources, scenes, project and serialized assets will be saved to disk.
1. Developers should agree on tabsize and whether to use tabs or spaces. Makes it less annoying to edit someone else's code. And makes it easier to resolve merge conflict. No more merging whitespace changes. http://editorconfig.org/
1. Git workflow! Branch out, create PR into Develop, create PR from Develop into Main. Branch out for smaller fixes, name with Project issue number.
1. Keep the files small < 300 lines. Makes it so much easier to a) understand what your colleagues are trying to achieve, b) reuse code, c) handle merge conflicts
1. Never use full class path when referencing classes, like void Func(A.B.C.D.Class property) { ... }. This makes the class rigid and difficult to work with. What if you need to move A.B.C.D.Class to a new namespace? Always use 'using A.B.C.D' at the top of the class. This makes it easier for other developers to grasp the scope of this class. By reading the using declarations you can better understand what other classes this class depends on, and that way get a better picture of where in the system this class is meant to be used.