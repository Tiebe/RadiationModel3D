
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Europium149 : RadioactiveSubstance
    {
        public override string name { get; } = "Europium149";
        public override double halfLife { get; } = 8043840.0d;
        public override double atomicWeight { get; } = 148.91794d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new Samarium149() } },

        };
    }
}
    
    