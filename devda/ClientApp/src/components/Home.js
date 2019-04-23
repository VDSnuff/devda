import React, { Component } from 'react';
import { PostView } from './PostView';

export class Home extends Component {
    static displayName = Home.name;

    render() {
        return (
            <div>
                <h1>The greatest f* blog in the world</h1>
                <p>Welcome to your new single-page application</p>
                <PostView />
            </div>
        );
    }
}
