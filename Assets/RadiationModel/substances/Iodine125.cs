
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iodine125 : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine125";
        public override double halfLife { get; } = 5131468.8d;
        public override double atomicWeight { get; } = 124.90463d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new Tellurium125() } },

        };
    }
}
    
    