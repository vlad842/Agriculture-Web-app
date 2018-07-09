import React, { Component } from 'react';
import {Button} from 'reactstrap';

import LoadingModal from './LoadingModal';

export default class DataBasePage extends Component {
    
    constructor(props){
        super(props);

        
    }

    render() {
        return (

            <div className="database-page">
                <div className="row">

                    <div className="transpaentBlackColors col-sm-2">
                        <div className="d-flex flex-column">
                            <div className="p-2"><Button className = "d-block" >1</Button></div>
                            <div className="p-2"><Button>2</Button></div>
                            <div className="p-2"><Button>3</Button></div>
                        </div>
                    </div>
                    <div className="col-md-11">
                    </div>
                </div>


            </div>
        );
    }
}
    // apiKey: 'AIzaSyCrDmbP56izyqBLy28WbwYZsnmDaNEszWo'
