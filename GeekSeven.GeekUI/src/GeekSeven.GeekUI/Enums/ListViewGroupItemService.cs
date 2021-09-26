namespace GeekSeven.GeekUI
{
    public class ListViewGroupItemService : IDisposable
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public ListViewGroupItemService()
        {
            Items = new Dictionary<string, bool>();
        }

        public Action<bool> OnChangeSelectedItem { get; set; }

        public bool IsSelectedItem { get; private set; }
        public string CurrentLink { get; private set; }

        private IDictionary<string,bool> Items { get; set; }

        public void ChangeSelectedItem(bool isSelected, string link)
        {
            if (Items.ContainsKey(link))
            {
                if (Items[link] == isSelected) return;
                else Items[link] = isSelected;
            }
            else
            {
                Items.Add(link, isSelected);
            }

            var result = Items.Values.Contains(true);

            if (result != IsSelectedItem)
            {
                IsSelectedItem = result;
                OnChangeSelectedItem?.Invoke(isSelected);
            }


            //if (link == CurrentLink)
            //{
            //    if (isSelected == IsSelectedItem)
            //    {
            //        return;
            //    }
            //    else
            //    {
            //        OnChangeSelectedItem?.Invoke(isSelected);
            //    }
            //}
            //else
            //{
            //    if (!isSelected & !IsSelectedItem)
            //    {
            //        CurrentLink = string.Empty;
            //        return;
            //    }

            //    if(!isSelected & link != CurrentLink)
            //    {
            //        return;
            //    }

            //    if(isSelected == IsSelectedItem)
            //    {
            //        CurrentLink = link;
            //        return;
            //    }

            //    OnChangeSelectedItem?.Invoke(isSelected);
            //    IsSelectedItem = isSelected;
            //    CurrentLink = link;
            //}
        
        }
    }
}
