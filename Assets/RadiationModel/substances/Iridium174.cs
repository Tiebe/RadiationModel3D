using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium174 : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium174";
        public override double halfLife { get; } = 7.9d;
        public override double atomicWeight { get; } = 173.96695d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.995d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Osmium174() } } },
            { 0.005d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rhenium170() }, { 1.0d, new AlphaParticle(6715002.09) }, { 0.00017d, new GammaParticle(31400.0, 0.03949) }, { 0.0024d, new GammaParticle(193500.0, 0.00641) }, { 0.0016d, new GammaParticle(224600.0, 0.00552) }, { 0.0013103610664000002d, new GammaParticle(10063.0, 0.12321) }, { 0.00017725585028979037d, new GammaParticle(59718.0, 0.02076) }, { 0.0003066710212626131d, new GammaParticle(61141.0, 0.02028) }, { 0.00010193917654471145d, new GammaParticle(69395.0, 0.01787) }, { 0.00013017632844759654d, new GammaParticle(70206.0, 0.01766) }, { 2.8237151902885074e-05d, new GammaParticle(71195.0, 0.01741) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    