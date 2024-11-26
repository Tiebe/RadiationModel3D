using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radium211m : RadioactiveSubstance
    {
        public override string name { get; } = "Radium211m";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 211.00218d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Radium211()), new(0.483d, new GammaParticle(396100.0, 0.00313)), new(1.0d, new GammaParticle(802000.0, 0.00155)), new(0.179587088284d, new GammaParticle(14920.0, 0.0831)), new(0.10749794987541181d, new GammaParticle(85432.0, 0.01451)), new(0.17559286160635706d, new GammaParticle(88471.0, 0.01401)), new(0.06160635882396928d, new GammaParticle(100119.0, 0.01238)), new(0.08181324451823122d, new GammaParticle(101370.0, 0.01223)), new(0.020206885694261923d, new GammaParticle(102948.0, 0.01204)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    