
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iodine122n : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine122n";
        public override double halfLife { get; } = 8e-05d;
        public override double atomicWeight { get; } = 121.908d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Iodine122() } },

        };
    }
}
    
    