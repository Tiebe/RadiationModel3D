using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Palladium128m : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium128m";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 127.95465d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Palladium128()), new(0.28d, new GammaParticle(75100.0, 0.01651)), new(0.74d, new GammaParticle(260100.0, 0.00477)), new(0.88d, new GammaParticle(504400.0, 0.00246)), new(1.0d, new GammaParticle(1311400.0, 0.00095)), new(0.05594547704d, new GammaParticle(3053.0, 0.40611)), new(0.18963719519504743d, new GammaParticle(21020.0, 0.05898)), new(0.3582792276498157d, new GammaParticle(21177.0, 0.05855)), new(0.09829714286763828d, new GammaParticle(23904.0, 0.05187)), new(0.11500765715513678d, new GammaParticle(24070.0, 0.05151)), new(0.016710514287498507d, new GammaParticle(24297.0, 0.05103)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    