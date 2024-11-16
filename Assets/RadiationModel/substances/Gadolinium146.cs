using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gadolinium146 : RadioactiveSubstance
    {
        public override string name { get; } = "Gadolinium146";
        public override double halfLife { get; } = 4170528.0d;
        public override double atomicWeight { get; } = 145.91832d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new Europium146() } },

        };
    }
}
    
    