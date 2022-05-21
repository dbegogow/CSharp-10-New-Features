using AssignmentAndDeclarationInSameDesconstruction;

var rectangle = new Rectangle(200, 100);

(int h, int w) = rectangle;

int height = 0;
//int width = 0;
(height, int width) = rectangle;