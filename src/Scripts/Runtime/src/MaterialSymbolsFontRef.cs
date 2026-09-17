using System.IO;
using UnityEngine;

namespace Racer.MaterialSymbols.Runtime
{
    public class MaterialSymbolsFontRef : ScriptableObject
    {
        private static MaterialSymbolsFontRef _instance;

        [SerializeField] private Font standard;
        [SerializeField] private Font filled;


        public Font Standard => standard;
        public Font Filled => filled ? filled : standard;

        public static MaterialSymbolsFontRef FontRef
        {
            get
            {
                if (_instance) return _instance;

                _instance = Resources.Load<MaterialSymbolsFontRef>(nameof(MaterialSymbolsFontRef));

                if (!_instance)
                    throw new FileNotFoundException(
                        $"{nameof(MaterialSymbolsFontRef)} asset not found! Re-install this package to fix the issue.");

                return _instance;
            }
        }
    }
}