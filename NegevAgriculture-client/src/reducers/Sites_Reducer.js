
import {FETCH_ALL_SITES} from '../actions/index';

export default function (state = [],action)
{
    switch (action.type)
    {
        case  FETCH_ALL_SITES:
            let sites = [];
            action.payload.data.forEach(site =>{
                sites[site.Id] = site;

            });
            return sites;
    }

    return state;
}