
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Terbium155 : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium155";
        public override double halfLife { get; } = 459648.0d;
        public override double atomicWeight { get; } = 154.92351d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new Gadolinium155() } },

        };
    }
}
    
    