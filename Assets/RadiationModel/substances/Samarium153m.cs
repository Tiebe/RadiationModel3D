using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Samarium153m : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium153m";
        public override double halfLife { get; } = 0.0106d;
        public override double atomicWeight { get; } = 152.92221d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Samarium153()), new(0.0039000000000000003d, new GammaParticle(7500.0, 0.16531)), new(4e-05d, new GammaParticle(11900.0, 0.10419)), new(0.501d, new GammaParticle(32900.0, 0.03769)), new(0.022044d, new GammaParticle(46100.0, 0.02689)), new(0.008517d, new GammaParticle(53600.0, 0.02313)), new(0.011523d, new GammaParticle(58000.0, 0.02138)), new(0.27792241131192d, new GammaParticle(6354.0, 0.19513)), new(0.020724224303837867d, new GammaParticle(39522.0, 0.03137)), new(0.037509908242240486d, new GammaParticle(40117.0, 0.03091)), new(0.011725521282926588d, new GammaParticle(45523.0, 0.02724)), new(0.014750705773921647d, new GammaParticle(45998.0, 0.02695)), new(0.00302518449099506d, new GammaParticle(46575.0, 0.02662)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    