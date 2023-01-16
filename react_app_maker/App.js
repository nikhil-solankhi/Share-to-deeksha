import { useEffect, useState } from "react";

const App = () => {

    //1 create useState
    const [employees, setEmployees] = useState([])

    //2 call api
    useEffect(() => {
        fetch("api/employee/GetEmployees")
            .then(response => { return response.json() })
            .then(responseJson => {

                setEmployees(responseJson)
            })
    },[])

    //3.- create div and table
    return (
        <div className="container">
            <h1>Employees</h1>
            <div className="row">
                <div className="col-sm-12">
                    <table className="table table-striped">
                        <thead>
                            <tr>
                                <th>IdEmployee</th>
                                <th>Name</th>
                                <th>Email</th>
                                <th>Address</th>
                                <th>Phone</th>
                            </tr>
                        </thead>
                        <tbody>
                            {
                                employees.map((item) => (
                                    <tr key={item.id}>
                                        <td>{item.id}</td>
                                        <td>{item.name}</td>
                                        <td>{item.email}</td>
                                        <td>{item.address}</td>
                                        <td>{item.phone}</td>
                                    </tr>
                                    
                                    ))
                            }
                        </tbody>
                    </table>
                </div>
            </div>
        </div>
    )
}

export default App;