[Codecov][0] C# Example using SharpCover
========================================

1. Follow instructions on [how to instrument coverage reports with SharpCover](https://github.com/codecov/example-csharp-sharpcover/blob/master/Makefile#L17-L21)
2. Call `bash <(curl -s https://codecov.io/bash) -t repository-upload-token` at the [end of your CI build](https://github.com/codecov/example-csharp-sharpcover/blob/master/.travis.yml#L11)
  - Is you repository public and tested with Travis, CircleCI or AppVeyor? Then the repository upload token is not required!

> Also see out [C# Example][1]




[0]: https://codecov.io/
[1]: https://github.com/codecov/example-csharp
