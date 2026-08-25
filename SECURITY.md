# Security Policy

## Overview

The security of CQGTool and its users is important to us.

If you discover a potential security vulnerability in this project, please report it responsibly so that we can investigate and address the issue before the vulnerability is publicly disclosed.

Please do not create a public GitHub Issue for security vulnerabilities.

## Supported Versions

We currently provide security updates for the latest released version of CQGTool.

| Version | Supported |
| --- | --- |
| Latest release | Yes |
| Older releases | No |

If you are unsure whether your version is supported, please include the version number in your security report.

## Reporting a Vulnerability

If you discover a security vulnerability in CQGTool, please use GitHub's **Private Vulnerability Reporting** feature.

Please do not publicly disclose the vulnerability or create a public GitHub Issue before the maintainers have had an opportunity to investigate and address the issue.

### How to Report

1. Open the CQGTool repository on GitHub.
2. Go to the **Security** tab.
3. Select **Report a vulnerability**.
4. Provide detailed information about the vulnerability.
5. Submit the report privately.

Private reporting helps prevent sensitive security information from becoming publicly available before a fix is released.

## Information to Include

When submitting a security report, please provide as much information as possible.

Please include:

- A clear description of the vulnerability
- The affected component, API, page, service, or feature
- The affected CQGTool version or commit
- Steps required to reproduce the issue
- Proof of concept, if available
- Potential security impact
- Relevant error messages or logs
- Suggested mitigation or fix, if known

Please do not include real passwords, API keys, access tokens, private keys, database credentials, personal information, or other sensitive information in the report.

## Vulnerability Review Process

After receiving a security report, the maintainers will:

1. Review the submitted report.
2. Verify and reproduce the reported vulnerability when possible.
3. Determine the severity and potential impact.
4. Identify affected versions and components.
5. Develop an appropriate security fix.
6. Test the security fix.
7. Release the fix through the appropriate release process.
8. Notify affected users when necessary.

Security-related discussions and technical details may remain private while the vulnerability is being investigated and resolved.

## Severity

Security vulnerabilities may be evaluated based on their potential impact.

Examples include:

- **Low** — Limited security impact or difficult to exploit.
- **Moderate** — Security issue with a meaningful but limited impact.
- **High** — Significant impact or relatively practical exploitation.
- **Critical** — Severe vulnerability that may allow major unauthorized access, data disclosure, remote code execution, or other serious compromise.

The final severity will be determined by the maintainers based on the actual impact and circumstances.

## Responsible Disclosure

We request that security researchers allow reasonable time for the maintainers to investigate and address a reported vulnerability before publicly disclosing technical details.

Security testing should be performed responsibly and only against systems, accounts, and data for which you have authorization.

Please do not:

- Access another user's account without authorization.
- Access or download data that does not belong to you.
- Modify or delete user or production data.
- Perform denial-of-service attacks.
- Destroy or intentionally damage systems.
- Obtain or expose passwords, API keys, access tokens, or other secrets.
- Use a vulnerability to cause harm to users or production systems.

A proof of concept should demonstrate the vulnerability without causing unnecessary damage.

## Security Updates

Security fixes may be released through:

- Normal application releases
- Patch releases
- Security advisories
- Emergency security updates

Users are encouraged to keep CQGTool and its dependencies up to date.

## Dependency Security

CQGTool may use third-party dependencies such as NuGet packages and other software dependencies.

Security vulnerabilities in dependencies may be identified through GitHub security tools such as **Dependabot**.

When a vulnerable dependency is identified, maintainers will evaluate the vulnerability and update the dependency when appropriate.

Users should keep their dependencies updated to supported versions.

## Secrets and Sensitive Information

Never commit secrets or sensitive credentials to the repository.

Examples include:

- Passwords
- API keys
- Access tokens
- Database usernames and passwords
- Private keys
- Cloud credentials
- Connection strings containing credentials
- Authentication secrets
- Certificates or private certificate keys

Use appropriate secret-management mechanisms instead, such as:

- Environment variables
- GitHub Actions Secrets
- .NET User Secrets for local development
- Secure cloud secret-management services

If a secret is accidentally committed to the repository, assume that the secret has been compromised and rotate or revoke it immediately.

## Security Scanning

CQGTool may use GitHub security features to identify potential security problems, including:

- Dependabot for vulnerable dependencies
- Code scanning for potential security issues in source code
- Secret scanning for exposed credentials and secrets

Security alerts should be reviewed and addressed by the maintainers as appropriate.

## Public Disclosure

Security vulnerabilities should not be publicly disclosed before the maintainers have had a reasonable opportunity to investigate and address the issue.

Once an issue has been resolved, the maintainers may publish appropriate security information or a security advisory when necessary.

## Security Contact

For security vulnerabilities, please use GitHub's **Private Vulnerability Reporting** feature.

Please do not use public GitHub Issues to report security vulnerabilities.

Thank you for helping us keep CQGTool and its users secure.
