using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Palladium105m : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium105m";
        public override double halfLife { get; } = 4e-05d;
        public override double atomicWeight { get; } = 104.9056d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Palladium105()), new(0.688d, new GammaParticle(182920.0, 0.00678)), new(0.9815d, new GammaParticle(306300.0, 0.00405)), new(0.01680595438d, new GammaParticle(3053.0, 0.40611)), new(0.06558608086503503d, new GammaParticle(21020.0, 0.05898)), new(0.1239109783960609d, new GammaParticle(21177.0, 0.05855)), new(0.033996096358037645d, new GammaParticle(23904.0, 0.05187)), new(0.03977543273890404d, new GammaParticle(24070.0, 0.05151)), new(0.005779336380866399d, new GammaParticle(24297.0, 0.05103)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    