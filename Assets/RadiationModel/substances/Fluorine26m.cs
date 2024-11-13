
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Fluorine26m : RadioactiveSubstance
    {
        public override string name { get; } = "Fluorine26m";
        public override double halfLife { get; } = 0.0022d;
        public override double atomicWeight { get; } = 26.02073d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.82d, new List<RadioactiveSubstance> { new GammaParticle(), new Fluorine26() } },

        };
    }
}
    
    