using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ytterbium169 : RadioactiveSubstance
    {
        public override string name { get; } = "Ytterbium169";
        public override double halfLife { get; } = 2766009.6d;
        public override double atomicWeight { get; } = 168.93518d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new Thulium169() } },

        };
    }
}
    
    