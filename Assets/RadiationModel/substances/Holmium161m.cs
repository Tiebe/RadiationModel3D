using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium161m : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium161m";
        public override double halfLife { get; } = 6.76d;
        public override double atomicWeight { get; } = 160.92809d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Holmium161() }, { 0.455d, new GammaParticle(211150.0, 0.00587) }, { 0.09043201622d, new GammaParticle(7656.0, 0.16194) }, { 0.05538486765899972d, new GammaParticle(46700.0, 0.02655) }, { 0.09863734222439842d, new GammaParticle(47547.0, 0.02608) }, { 0.03186792866396976d, new GammaParticle(53982.0, 0.02297) }, { 0.04015359011660189d, new GammaParticle(54577.0, 0.02272) }, { 0.008285661452632136d, new GammaParticle(55293.0, 0.02242) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    