
// It's generated file. DO NOT MODIFY IT!
class ItemPropertyInfoBlockLoader : Datasheet.Loader<ItemPropertyInfo.Block>
{

    public void LoadRecord(ref ItemPropertyInfo.Block record, Datasheet.Stream stream)
    {
                stream.Read(ref record.set);
                stream.Read(ref record.value);
                stream.Read(ref record.func);
                stream.Read(ref record.statId);
    }
}
