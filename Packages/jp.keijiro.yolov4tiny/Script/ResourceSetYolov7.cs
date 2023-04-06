using UnityEngine;
using Unity.Barracuda;

namespace YoloV7Tiny {

[CreateAssetMenu(fileName = "yolov7Tiny",
                 menuName = "ScriptableObjects/YoloV7Tiny Resource Set")]
public sealed class ResourceSet : ScriptableObject
{
    public NNModel model;
    public float[] anchors = new float[12];
    public ComputeShader preprocess;
    public ComputeShader postprocess1;
    public ComputeShader postprocess2;
}

} // namespace yolov7Tiny
