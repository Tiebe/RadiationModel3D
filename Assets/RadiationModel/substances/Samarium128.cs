
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Samarium128 : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium128";
        public override double halfLife { get; } = 0.5d;
        public override double atomicWeight { get; } = 127.95797d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    