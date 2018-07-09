import axios from 'axios';

export const ZOOM_CHANGED = "ZOOM_CHANGED";
export function change_map_zoom(number)
{
    return {
        type: 'ZOOM_CHANGED',
        payLoad: number
    };
}

export const DRAW_STATE_CHANGE = "DRAW_STATE_CHANGE";
export function toggle_drawing_state()
{
    return{
        type: "DRAW_STATE_CHANGE",
    };
}

export const FETCH_LAYERS_NAMES = "FETCH_LAYERS_NAMES";
export function fetch_layers_names()
{
    const request = axios.get("http://localhost:27434/api/layers/layersNamesIDs");

    return {
        type : FETCH_LAYERS_NAMES,
        payload : request
    }
}

export const FETCH_LAYERS_DATA = "FETCH_LAYERS_DATA";
export function fetch_layer_data(layer_id,onStart,onEnd)
{
    onStart();
    const request = axios.get(`http://localhost:27434/api/layers/layerByID?i_ID=${layer_id}`).then(function(response)
    {
        onEnd();
        return response;
    });

    
    return {
        type : FETCH_LAYERS_DATA,
        payload : request
    }
}

export const TOGGLE_SELECT_LAYER = "TOGGLE_SELECT_LAYER";
export function toggle_select_layer(layer_id)
{
    return {
        type: TOGGLE_SELECT_LAYER,
        payload: layer_id
    }
}

export const SELECT_LAYER = "SELECT_LAYER";
export function select_layer(layer_id)
{
    return {
        type: SELECT_LAYER,
        payload: layer_id
    }
}

export const UDSELECT_LAYER = "UDSELECT_LAYER";
export function unselect_layer(layer_id)
{
    return {
        type: UDSELECT_LAYER,
        payload: layer_id
    }
}

export const FETCH_ALL_SITES = "FETCH_ALL_SITES";
export function fetch_all_sites(onStart,onEnd)
{
    onStart();
    const request = axios.get("http://localhost:27434/api/sites/getAllSites").then(function (response) {
        onEnd();
        return response;
      });

    return{
        type : FETCH_ALL_SITES,
        payload : request
    };
}

export const TOGGLE_SELECT_SITE = "TOGGLE_SELECT_SITE";
export function toggle_select_site(site)
{
    return{
        type : TOGGLE_SELECT_SITE,
        payload : site
    };
}

export const CHANGE_LOADING_MODAL = "CHANGE_LOADING_MODAL";
export function change_loading_modal(visibility,context,progress)
{
    return{
        type : CHANGE_LOADING_MODAL,
        payload : {visibility:visibility,
                   context:context,
                   progress:progress}
    };
}

export const HIDE_LOADING_MODAL = "HIDE_LOADING_MODAL";
export function hide_loading_modal()
{
    return{
        type : HIDE_LOADING_MODAL
    };
}

export const SHOW_LOADING_MODAL = "SHOW_LOADING_MODAL";
export function show_loading_modal(visibility,context,progress)
{
    return{
        type : CHANGE_LOADING_MODAL,
        payload : {visibility:visibility,
                   context:context,
                   progress:progress}
    };
}

export const SET_LOADING_MODAL_PROGRESS = "SET_LOADING_MODAL_PROGRESS";
export function set_loading_modal_progress(progress)
{
    return{
        type : SET_LOADING_MODAL_PROGRESS,
        payload : progress
    };
}




