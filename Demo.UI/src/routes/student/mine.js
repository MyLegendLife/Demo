import React, { Component } from 'react';
import { connect } from 'dva';
import { Table } from 'antd';

@connect(({ student, loading }) => ({
  student,
  loading: loading.effects['student/getData'],
}))
export default class Mine extends Component {
  componentDidMount() {
    const { dispatch } = this.props;

    dispatch({
      type: 'student/getData',
    });
  }

  render() {
    const { student } = this.props;
    const { mineData } = student;

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
