import { useEffect } from 'react';
import { Container } from 'semantic-ui-react';
import NavBar from './NavBar';
import ActivityDashboard from '../../features/activities/dashboard/ActivityDashboard';
import LoadingComponent from './LoadingComponent';
import { useStore } from '../stores/store';
import { observer } from 'mobx-react-lite';

function App() {
  const { activityStore } = useStore();

  useEffect(() => {
    activityStore.loadActivities();
  }, [activityStore])

  if (activityStore.loadingInitial) return <LoadingComponent content='Loading app...' />

  return (
    <>
      <NavBar />
      <Container style={{ marginTop: '7em' }}>
        {/* <p>{practiceStore.counter}</p> <p>{practiceStore.counter2}</p>
        <p>{practiceStore.counter > 5 ? "Greater than 5" : "Lesser than 5"}</p>
        <Button onClick={() => practiceStore.setCounter()}>Increase Counter</Button>
        <Button onClick={() => practiceStore.setCounter2()}>Increase Counter 2</Button>
        <br /> */}
        <ActivityDashboard />
      </Container>
    </>
  );
}

export default observer(App);
