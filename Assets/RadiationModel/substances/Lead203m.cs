using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead203m : RadioactiveSubstance
    {
        public override string name { get; } = "Lead203m";
        public override double halfLife { get; } = 6.21d;
        public override double atomicWeight { get; } = 202.97428d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lead203()), new(1.463e-11d, new GammaParticle(5000.0, 0.24797)), new(0.057d, new GammaParticle(820200.0, 0.00151)), new(0.726d, new GammaParticle(825100.0, 0.0015)), new(0.06566213696658d, new GammaParticle(12522.0, 0.09901)), new(0.04417782728851155d, new GammaParticle(72805.0, 0.01703)), new(0.07424844922438915d, new GammaParticle(74970.0, 0.01654)), new(0.02537705925276444d, new GammaParticle(84986.0, 0.01459)), new(0.0330409311470993d, new GammaParticle(86022.0, 0.01441)), new(0.0076638718943348606d, new GammaParticle(87301.0, 0.0142)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    