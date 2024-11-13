
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tungsten164 : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten164";
        public override double halfLife { get; } = 6.3d;
        public override double atomicWeight { get; } = 163.95895d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.9620000000000001d, new List<RadioactiveSubstance> { new BetaParticle(), new Tantalum164() } },

            { 0.038d, new List<RadioactiveSubstance> { new AlphaParticle(), new Hafnium160() } },

        };
    }
}
    
    