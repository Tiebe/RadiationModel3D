using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Fermium253 : RadioactiveSubstance
    {
        public override string name { get; } = "Fermium253";
        public override double halfLife { get; } = 259200.0d;
        public override double atomicWeight { get; } = 253.08518d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.88d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Einsteinium253() } } },
            { 0.12d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Californium249() }, { 1.0d, new AlphaParticle(8219802.089999999) }, { 0.0019d, new GammaParticle(144800.0, 0.00856) }, { 0.026000000000000002d, new GammaParticle(271800.0, 0.00456) }, { 0.00084d, new GammaParticle(405000.0, 0.00306) }, { 0.0552633431784d, new GammaParticle(19579.0, 0.06333) }, { 0.017712829363099408d, new GammaParticle(109867.0, 0.01128) }, { 0.027410754198544423d, new GammaParticle(115063.0, 0.01078) }, { 0.010448971414716934d, new GammaParticle(129671.0, 0.00956) }, { 0.014168805238356164d, new GammaParticle(131332.0, 0.00944) }, { 0.0037198338236392285d, new GammaParticle(133529.0, 0.00929) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    