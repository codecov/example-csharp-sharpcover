# [Codecov](https://codecov.io) C# Example using SharpCover

[![FOSSA Status](https://app.fossa.com/api/projects/git%2Bgithub.com%2Fcodecov%2Fexample-csharp-sharpcover.svg?type=shield)](https://app.fossa.com/projects/git%2Bgithub.com%2Fcodecov%2Fexample-csharp-sharpcover?ref=badge_shield)

**Work in progress. Support for SharpCover is not complete yet.
Thank you for your patience.**

1.  Follow instructions on [how to instrument coverage reports with SharpCover][2]
2.  Call `bash <(curl -s https://codecov.io/bash) -t repository-upload-token`
    at the [end of your CI build][3].

Also see our [C# Example][1]

## Caveats
### Private Repo
Repository tokens are required for (a) all private repos, (b) public repos not using Travis-CI, CircleCI or AppVeyor. Find your repository token at Codecov and provide via appending `-t <your upload token>` to you where you upload reports.

## Links
- [Community Boards](https://community.codecov.io)
- [Support](https://codecov.io/support)
- [Documentation](https://docs.codecov.io)

[1]: https://github.com/codecov/example-csharp
[2]: https://github.com/codecov/example-csharp-sharpcover/blob/master/Makefile#L17-L21
[3]: https://github.com/codecov/example-csharp-sharpcover/blob/master/.travis.yml#L11

## License
[![FOSSA Status](https://app.fossa.com/api/projects/git%2Bgithub.com%2Fcodecov%2Fexample-csharp-sharpcover.svg?type=large)](https://app.fossa.com/projects/git%2Bgithub.com%2Fcodecov%2Fexample-csharp-sharpcover?ref=badge_large)