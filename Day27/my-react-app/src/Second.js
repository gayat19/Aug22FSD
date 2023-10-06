import './Second.css';

function Second(props) {
  
  return (
    <div className="alert alert-success myHeading">
      <h1>Second Component - {props.ename}</h1>
    </div>
  );
}

export default Second;
