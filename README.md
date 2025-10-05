# PrometheusGrafanaDemo

A dockerized sandbox to demonstrate the use of Prometheus and Grafana with a .NET 8 web API.

Prerequisites:

* Install Docker Desktop

Running the demo:

1. Open a terminal at `.\src` and run `docker compose -p prometheus-grafana-demo up --build`
2. Access Grafana at [localhost:3000](http://localhost:3000) and enter `admin` for both the username and password
3. Navigate to "Connections" and then "Add new connection"
4. Select "Prometheus" from the list and click "Add new data source"
5. Enter `http://prometheus:9090` as the URL and click "Save & test"

You can now experiment with the various features of Grafana, such as building dashboards or drilling down into metrics. Additionally, Prometheus can be accessed at [localhost:9090](http://localhost:9090) where you can experiment with queries and alerts.
