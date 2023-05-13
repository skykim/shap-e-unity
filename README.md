# shap-e-unity
Visualize 3D objects made with OpenAI Shap-E

[![Visualize 3D objects made with OpenAI Shap-E (Youtube)](https://img.youtube.com/vi/FlhMAYIn45E/0.jpg)](https://www.youtube.com/watch?v=FlhMAYIn45E)

- Sample prompt of "Text to 3D"
  - an alligator
  - a cheetah
  - an elephant
  - a cat that looks like a zebra
  - a flamingo that looks like a penguin
  - a pig that looks like a giraffe
  - a polar bear that looks like a panda
  - a rabbit that looks like a bird
  - a turtle that looks like a giraffe

## Usage

In Shap-E,
- Follow the instruction on https://github.com/openai/shap-e
- Save the output as an .obj file
- Convert .obj to .fbx using Blender

In Unity,
- Import .fbx file
- The color is stored in Vertex Color in the .fbx file
- The material generated from the HDRP shader graph were used to represent the vertex color

## Environment
- Unity 2021.3.19f1

## Reference
- https://github.com/openai/shap-e
