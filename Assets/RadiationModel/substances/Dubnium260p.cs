using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dubnium260p : RadioactiveSubstance
    {
        public override string name { get; } = "Dubnium260p";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 260.1114d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    