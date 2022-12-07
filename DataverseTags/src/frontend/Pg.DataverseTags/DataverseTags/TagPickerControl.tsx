import * as React from 'react';
import { Label } from '@fluentui/react';
import { TagPicker } from 'rsuite';
import { IInputs, IOutputs } from "./generated/ManifestTypes";
import { DataLayerService, IDataLayerService } from './DataLayerService'

export interface ITagPickerControlProps {
  tags?: string;
  controlContext: ComponentFramework.Context<IInputs>; 
  onChange: (value: string) => void; 
}

interface ITagItem {
  label: string, 
  value: string
}

interface IState {
  selectedTags: Array<string>;
  tags: Array<ITagItem>;
}

export class TagPickerControl extends React.Component<ITagPickerControlProps> {

  state: IState = {
    selectedTags: [], 
    tags: []
  }

  dataService: IDataLayerService

  constructor(props: ITagPickerControlProps) {
    super(props);

    this.setData = this.setData.bind(this);

    this.dataService = new DataLayerService(props.controlContext.webAPI);
    this.dataService.getActiveTags(this.setData, this.handleErrors); 

    if (props.tags) {
      var tags = props.tags.split(';');
      this.state.selectedTags = tags;
    }  
  }

  public render(): React.ReactNode {
    return (
      <div>
        {/* <Label>
          {this.props.tags}
        </Label> */}
        <TagPicker
          creatable
          data={this.state.tags}
          style={{ width: 300 }}
          menuStyle={{ width: 300 }}
          defaultValue={this.state.selectedTags}
          onCreate={(value: any, item: any) => {
            console.log(value, item);
          }}
          onChange= {(value:string[], event) => {
            var ret = value.join(';'); 
            console.log(ret); 
            this.props.onChange(ret); 
            //Sample code how to update value on form: https://powerusers.microsoft.com/t5/Power-Apps-Pro-Dev-ISV/Change-bound-field-value/td-p/489516
          }}
        />
      </div>
    )
  }

  private setData(records: any): void {
    var list = records.entities.map(
      item => ({
        label: item.pg_name,
        value: item.pg_name
      })
    );

    this.setState({ tags: list })
  }

  private handleErrors(error: any): void {
    console.log(error);
  }

}
