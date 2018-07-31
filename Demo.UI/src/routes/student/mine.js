import React, { Component } from 'react';
import { connect } from 'dva';
import { Table } from 'antd';

@connect((mine, loading) => ({
  mine,
  loading: loading.effects['mine/getData'],
}))
export default class Minde extends component {
  componentDidMount() {
    const { dispatch } = this.props;

    dispatch({
      type: 'mine/getData',
    });
  }

  render() {
    const { mine } = this.props;
    const { mineData } = mine;

    const columns = [
      {
        title: '姓名',
        dataIndex: 'name',
        key: 'name',
      },
      {
        title: '年龄',
        dataIndex: 'age',
        key: 'age',
      },
      {
        title: '住址',
        dataIndex: 'address',
        key: 'address',
      },
    ];

    return (
      <div>
        <Table dataSource={mineData} columns={columns} />
      </div>
    );
  }
}
