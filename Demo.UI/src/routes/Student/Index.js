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
    const { users } = student;

    const columns = [
      {
        title: 'Id',
        dataIndex: 'Id',
        key: 'Id',
      },
      {
        title: '姓名',
        dataIndex: 'Name',
        key: 'Name',
      },
      {
        title: '电话',
        dataIndex: 'Tel',
        key: 'Tel',
      },
      {
        title: '等级',
        dataIndex: 'Level',
        key: 'Level',
      },
      {
        title: '创建时间',
        dataIndex: 'CreateDate',
        key: 'CreateDate',
      },
    ];

    return (
      <div>
        <Table dataSource={users} columns={columns} />
      </div>
    );
  }
}
