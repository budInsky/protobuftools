echo on
protoc --descriptor_set_out=Protocal.protobin --include_imports Protocal.proto 
protogen Protocal.protobin