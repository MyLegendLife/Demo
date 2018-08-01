import React, { Component } from 'react';
import { connect } from 'dva';
import { Table } from 'antd';

@connect(({ student, loading }) => ({
  student,
  loading: loading.effects['student/getUsers'],
}))
export default class Index extends Component {
  componentDidMount() {
    const { dispatch } = this.props;

    dispatch({
      type: 'student/getUsers',
    });
  }

  render() {
    const { student } = this.props;
    const { mineData } = student;

    const columns = [
      {
        title: 'Id',
        dataIndex: 'id',
        key: 'id',
      },
      {
        title: '姓名',
        dataIndex: 'name',
        key: 'name',
      },
      {
        title: '电话',
        dataIndex: 'tel',
        key: 'tel',
      },
      {
        title: '等级',
        dataIndex: 'level',
        key: 'level',
      },
      {
        title: '创建时间',
        dataIndex: 'createDate',
        key: 'createDate',
      },
    ];

    return (
      <div>
        <Table dataSource={mineData} columns={columns} />
      </div>
    );
  }
}
