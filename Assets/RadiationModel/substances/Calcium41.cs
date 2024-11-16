using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Calcium41 : RadioactiveSubstance
    {
        public override string name { get; } = "Calcium41";
        public override double halfLife { get; } = 3136761028800.0d;
        public override double atomicWeight { get; } = 40.96228d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new Potassium41() } },

        };
    }
}
    
    