
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cadmium109 : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium109";
        public override double halfLife { get; } = 39856320.0d;
        public override double atomicWeight { get; } = 108.90499d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new Silver109() } },

        };
    }
}
    
    