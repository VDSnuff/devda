import React, { Component } from 'react';

export class PostView extends Component {
    static displayName = PostView.name;

    constructor(props) {
        super(props);
        this.state = { posts: [], loading: true };

        fetch('api/post')
            .then(response => response.json())
            .then(data => {
                this.setState({ posts: data, loading: false });
            });
    }

    static renderPostsView(posts) {
        return (
            <div>
                {posts.map(post =>
                    <div>
                        <h2>{post.Title}</h2>
                        <p>{post.User}</p>
                        <p>{post.Content}</p>
                    </div>
                )}
            </div>
        );
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : PostView.renderPostsView(this.state.posts);

        return (
            <div>
                {contents}
            </div>
        );
    }
}
