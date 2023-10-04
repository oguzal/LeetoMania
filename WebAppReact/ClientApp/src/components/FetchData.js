import React, { Component } from 'react';
import authService from './api-authorization/AuthorizeService'

export class FetchData extends Component {
    static displayName = FetchData.name;

    constructor(props) {
        super(props);
        //    this.state = { forecasts: [], loading: true };
        this.state = { result: {}, loading: true };
    }

    componentDidMount() {
        this.populateWeatherData();
    }

    static renderForecastsTable(result) {
        return (
            <table className="table table-striped" aria-labelledby="tableLabel">
                <thead>
                    <tr>
                        <th>Date</th>
                        <th>Temp. (C)</th>
                        <th>Temp. (F)</th>
                        <th>Summary</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>{result.current.last_updated} </td>
                        <td>{result.current.temp_c} </td>
                        <td>{result.current.temp_f} </td>
                        <td> </td>
                    </tr>
                    {/*{forecasts.map(forecast =>*/}
                    {/*    <tr key={forecast.date}>*/}
                    {/*        <td>{forecast.date}</td>*/}
                    {/*        <td>{forecast.temperatureC}</td>*/}
                    {/*        <td>{forecast.temperatureF}</td>*/}
                    {/*        <td>{forecast.summary}</td>*/}
                    {/*    </tr>*/}
                    {/*)}*/}
                </tbody>
            </table>
        );
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : FetchData.renderForecastsTable(this.state.result);

        return (
            <div>
                <h1 id="tableLabel">Weather forecast</h1>
                <p>This component demonstrates fetching data from the server.</p>
                {contents}
            </div>
        );
    }

    async populateWeatherData() {
        const token = await authService.getAccessToken();
        const response = await fetch('weatherforecast', {
//            headers: {}
                    headers: !token ? {} :            { 'Authorization': `Bearer ${token}` }
        });
        const data = await response.json();
        console.log("data:" + data);
        this.setState({ result: data, loading: false });
    }
}
