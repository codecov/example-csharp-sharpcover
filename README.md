# [Codecov][0] C# Example using SharpCover

**Work in progress. Support for SharpCover is not complete yet.
Thank you for your patience.**

1.  Follow instructions on [how to instrument coverage reports with SharpCover][2]
2.  Call `bash <(curl -s https://codecov.io/bash) -t repository-upload-token`
    at the [end of your CI build][3].

    **Note:** Is your repository public and tested with `Travis`, `CircleCI`
    or `AppVeyor`? Then the repository upload token is not required!

Also see our [C# Example][1]

[0]: https://codecov.io/

[1]: https://github.com/codecov/example-csharp

[2]: https://github.com/codecov/example-csharp-sharpcover/blob/master/Makefile#L17-L21

[3]: https://github.com/codecov/example-csharp-sharpcover/blob/master/.travis.yml#L11
