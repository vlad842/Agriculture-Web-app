import { combineReducers } from 'redux';

import LayersNames from './LayerNames_Reducer';
import Layers from './Layers_Reducer';
import SelectedLayers from './SelectedLayers_Reducer';

import CropsNames from './CropsNames_Reducer';

import Sites from './Sites_Reducer';

import CurrentZoom from './CurrentZoom_Reducer';
import DrawingState from './DrawState_Reducer';
import SelectedSites from './SelectedSites_Reducer';
import LoadingModal from './LoadingModal_Reducer';

const rootReducer = combineReducers({
  layersNames:LayersNames,
  cropsNames:CropsNames,
  currentZoom:CurrentZoom,
  drawingState:DrawingState,
  sites:Sites,
  layers:Layers,
  selectedLayers:SelectedLayers,
  selectedSites:SelectedSites,
  loadingModal:LoadingModal
});

export default rootReducer;
