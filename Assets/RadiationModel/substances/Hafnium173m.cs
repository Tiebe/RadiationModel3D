using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium173m : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium173m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 172.94063d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.01159, 107000.0), new Hafnium173() } },

        };
    }
}
    
    