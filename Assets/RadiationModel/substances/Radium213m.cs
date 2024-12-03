using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Radium213m : RadioactiveSubstance
    {
        public override string name { get; } = "Radium213m";
        public override double halfLife { get; } = 0.00218d;
        public override double atomicWeight { get; } = 213.00227d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.9940000000000001d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Radium213()), new(0.42200000000000004d, new GammaParticle(160870.0, 0.00771)), new(0.93d, new GammaParticle(546350.0, 0.00227)), new(0.9840000000000001d, new GammaParticle(1062500.0, 0.00117)), new(0.203492862496d, new GammaParticle(14920.0, 0.0831)), new(0.03679204145966525d, new GammaParticle(85432.0, 0.01451)), new(0.06009807490961327d, new GammaParticle(88471.0, 0.01401)), new(0.021085273818314376d, new GammaParticle(100119.0, 0.01238)), new(0.02800124363072149d, new GammaParticle(101370.0, 0.01223)), new(0.006915969812407116d, new GammaParticle(102948.0, 0.01204)) } },
            { 0.006d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Radon209()), new(1.0d, new AlphaParticle(9652002.09)), new(1.1000000000000001e-05d, new GammaParticle(104800.0, 0.01183)), new(0.00029d, new GammaParticle(110200.0, 0.01125)), new(4e-05d, new GammaParticle(214900.0, 0.00577)), new(0.00056177478976d, new GammaParticle(14088.0, 0.08801)), new(6.347143534368524e-05d, new GammaParticle(81070.0, 0.01529)), new(0.00010470378644619803d, new GammaParticle(83789.0, 0.0148)), new(3.631055925008844e-05d, new GammaParticle(94878.0, 0.01307)), new(4.792993821011674e-05d, new GammaParticle(96054.0, 0.01291)), new(1.1619378960028302e-05d, new GammaParticle(97530.0, 0.01271)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    