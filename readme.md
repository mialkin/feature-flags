# Feature flags

1\. Run infrastructure:

```bash
make run-infrastructure
```

2\. Navigate to <http://localhost:3010> and log in using `admin` as a username and `unleash4all` as a password.

3\. Go to <http://localhost:3010/admin/api> and create an API access token or use default one provided.

4\. Go to <http://localhost:3010/projects/default> and create new feature toggle with `SuperAwesomeFeature` name.

5\. Run `Unleash.Api` project in IDE and navigate to <http://localhost:5080> and execute the endpoint several times to check if `SuperAwesomeFeature` feature toggle is enabled.
