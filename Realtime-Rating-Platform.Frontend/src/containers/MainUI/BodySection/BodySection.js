import * as React from 'react';
import { DrawerHeader, Main } from './settings/Main';


export default function BodySection(props) {

  return (
    <Main open={props.open}>
        <DrawerHeader />
            {props.children}
    </Main>
  )
}
