
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Arsenic73 : RadioactiveSubstance
    {
        public override string name { get; } = "Arsenic73";
        public override double halfLife { get; } = 6937920.0d;
        public override double atomicWeight { get; } = 72.92383d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new Germanium73() } },

        };
    }
}
    
    