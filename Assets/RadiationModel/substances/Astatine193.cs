using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine193 : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine193";
        public override double halfLife { get; } = 0.028d;
        public override double atomicWeight { get; } = 192.99993d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Bismuth189() }, { 1.0d, new AlphaParticle(8595002.09) }, { 0.00031d, new GammaParticle(84000.0, 0.01476) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    