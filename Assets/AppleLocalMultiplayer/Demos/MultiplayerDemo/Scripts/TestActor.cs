using UnityEngine;
using UnityEngine.Networking;

#pragma warning disable 618

namespace LostPolygon.Apple.LocalMultiplayer.Demos {
    /// <summary>
    /// A very simple object. Moves to the position of the touch with interpolation.
    /// </summary>
    public class TestActor : NetworkBehaviour {
        public float Speed = 100f;

        [SyncVar]
        public float PositionRandomOffset = 0f;

//        private Vector3 _destination;
//        private SpriteRenderer _spriteRenderer;
//        private Rigidbody2D _rigidbody2D;

        [SyncVar(hook = "OnColorChangedHandler")]
        private Color _color;
        private TextMesh text;

        [SyncVar(hook = "OnTransformLocalScaleChangedHandler")]
        public Vector3 TransformLocalScale;

//        private readonly Color[] kColors = {
            //Color.white,
//            Color.blue,
//            Color.cyan,
/*            Color.green,
            Color.magenta,
            Color.red,
            Color.yellow
        };
*/
        private void Awake() {
/*          _spriteRenderer = GetComponent<SpriteRenderer>();
            _rigidbody2D = GetComponent<Rigidbody2D>();
            _destination = transform.position;

            _color = kColors[Random.Range(0, kColors.Length)];
            _spriteRenderer.color = _color;
            TransformLocalScale = transform.localScale;
            */
//            GameObject x = new GameObject();
//            TextMesh text = x.AddComponent<TextMesh>() as TextMesh;

/*          text = GetComponent<TextMesh>();

            text.characterSize = 0.1f;
						text.fontSize = 10;
            text.transform.position = new Vector3(0, 0, 1);
            text.text = "hi!!!!";
            text.transform.parent = Camera.main.transform;
            */
        }

        private void Update() {
/*            transform.localScale = new Vector3(0.1, 0.1, 0.1);

            if (!hasAuthority)
                return;

            if (Input.GetMouseButtonDown(0)) {
                _destination = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                _destination += (Vector3) (Random.insideUnitCircle * PositionRandomOffset);
            }
            */
        }

        private void FixedUpdate() {
  /*          if (!hasAuthority)
                return;

            _destination.z = 0f;
            _rigidbody2D.position = Vector3.MoveTowards(_rigidbody2D.position, _destination, Speed * Time.deltaTime);
*/
        }

        private void OnTransformLocalScaleChangedHandler(Vector3 localScale) {
//            transform.localScale = localScale;
        }

        private void OnColorChangedHandler(Color color) {
//            _spriteRenderer.color = color;
        }

        public override void OnStartClient() {
//           OnTransformLocalScaleChangedHandler(TransformLocalScale);
//            OnColorChangedHandler(_color);
        }
    }
}

#pragma warning restore 618
