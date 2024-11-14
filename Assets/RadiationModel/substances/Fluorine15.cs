using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Fluorine15 : RadioactiveSubstance
    {
        public override string name { get; } = "Fluorine15";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 15.01779d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new ProtonParticle(), new Oxygen14() } },

        };
    }
}
    
    